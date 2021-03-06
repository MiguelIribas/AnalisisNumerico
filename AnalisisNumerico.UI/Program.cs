﻿using AnalisisNumerico.Entidades;
using AnalisisNumerico.Entidades.Ecuaciones;
using AnalisisNumerico.Entidades.AjusteDeCurvas;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.Logica;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    static class Program
    {
        internal static Container container;

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
            container.Register<IMetodosCerrados, Logica.Unidad_1.MetodosCerrados>();
            container.Register<IMetodosAbiertos, Logica.Unidad_1.MetodosAbiertos>();
            container.Register<IEcuaciones, Logica.Unidad_2.MetodosEcuaciones>();
            container.Register<IMinimosCuadrados, Logica.Unidad_3.MinimosCuadrados>();
            container.Register<IIntegracionNumerica, Logica.Unidad_4.IntegracionNumerica>();
            container.Register<InicioForm>();
            container.Register<FormularioMetodosCerrados>();
            container.Register<FormularioMetodosAbiertos>();
            container.Register<FormularioSistemasEcuaciones>();
            container.Register<FormularioMinimosCuadrados>();
            container.Register<FormularioIntegracionNumerica>();
        }
    }
}
