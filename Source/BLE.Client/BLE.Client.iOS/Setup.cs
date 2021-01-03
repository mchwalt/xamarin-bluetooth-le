using Acr.UserDialogs;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Plugin.Permissions;
using Plugin.Settings;

namespace BLE.Client.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        protected override IMvxApplication CreateApp()
        {
            return new BleMvxApplication();
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();

            Mvx.RegisterSingleton(() => UserDialogs.Instance);
            Mvx.RegisterSingleton(() => CrossSettings.Current);
            Mvx.RegisterSingleton(() => CrossPermissions.Current);
        }
//        protected override IMvxIoCProvider InitializeIoC()
//        {
//            IMvxIoCProvider mvxIoCProvider = base.InitializeIoC();
//
//            mvxIoCProvider.RegisterSingleton(() => UserDialogs.Instance);
//            mvxIoCProvider.RegisterSingleton(() => CrossSettings.Current);
//            mvxIoCProvider.RegisterSingleton(() => CrossPermissions.Current);
//            return mvxIoCProvider;
//        }

        protected override Xamarin.Forms.Application CreateFormsApplication()
        {
            return new BleMvxFormsApp();
        }

        /*
        public override IEnumerable<Assembly> GetPluginAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(MvvmCross.Plugins.BLE.iOS.Plugin).GetTypeInfo().Assembly }));
        }
        */
    }
}
