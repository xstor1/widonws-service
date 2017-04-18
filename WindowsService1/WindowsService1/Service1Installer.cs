using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace WindowsService1
{
    [RunInstaller(true)]
    [System.ComponentModel.DesignerCategory("")]
    public class Service1Installer : Installer
    {
        
        //dsafg
       
        public Service1Installer()
        {
            ServiceProcessInstaller serviceProcessInstaller =
                               new ServiceProcessInstaller();
            ServiceInstaller serviceInstaller = new ServiceInstaller();

            // spouštění pod účtem LocalSystem
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceProcessInstaller.Username = null;
            serviceProcessInstaller.Password = null;

            // unikátní název, název pro zobrazení a popis
            serviceInstaller.ServiceName = "MyWindowsService";
            serviceInstaller.DisplayName = "My service";
            serviceInstaller.Description = "Popis služby";

            // způsob spouštění
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            this.Installers.Add(serviceProcessInstaller);
            this.Installers.Add(serviceInstaller);
        }
    }
}
