using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using Database.Implements;

namespace SUBD
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
	
		private static IUnityContainer container = null;
		public static IUnityContainer Container
		{
			get
			{
				if (container == null)
				{
					container = BuildUnityContainer();
				}
				return container;
			}
		}

		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Container.Resolve<FormMain>());
		}
		private static IUnityContainer BuildUnityContainer()
		{
			var currentContainer = new UnityContainer();
			currentContainer.RegisterType<PostStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<ProjectNumberStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<ProjectTypeStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<PurposeStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<StaffStorage>(new HierarchicalLifetimeManager());
			return currentContainer;
		}

	}
}
