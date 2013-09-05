using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-84 Implementing IDisposable and a finalizer.")]
    internal class ImplementingIDisposableAndAFinalizer : ISample
    {
        public void Run()
        {
        }

        private class UnmanagedWrapper : IDisposable
        {
            private IntPtr unmanagedBuffer;

            public UnmanagedWrapper()
            {
                CreateBuffer();
                Stream = File.Open("temp.dat", FileMode.Create);
            }

            public FileStream Stream { get; private set; }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            private void CreateBuffer()
            {
                var data = new byte[1024];
                new Random().NextBytes(data);
                unmanagedBuffer = Marshal.AllocHGlobal(data.Length);
                Marshal.Copy(data, 0, unmanagedBuffer, data.Length);
            }

            ~UnmanagedWrapper()
            {
                Dispose(false);
            }

            public void Close()
            {
                Dispose();
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(unmanagedBuffer);
                if (disposing)
                {
                    if (Stream != null)
                    {
                        Stream.Close();
                    }
                }
            }
        }
    }
}