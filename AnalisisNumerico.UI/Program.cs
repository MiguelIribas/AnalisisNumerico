using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    static class Program
    {
        private static Container container;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<InicioForm>());

        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<IMetodosRaices, MetodosRaices>();
            container.Register<InicioForm>();

            // Optionally verify the container.
            container.Verify();
        }


    }
}
