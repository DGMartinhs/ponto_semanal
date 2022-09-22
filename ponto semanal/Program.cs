using System;

namespace ponto_semanal
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (login frm = new login())
                frm.ShowDialog();

        }
    }
}