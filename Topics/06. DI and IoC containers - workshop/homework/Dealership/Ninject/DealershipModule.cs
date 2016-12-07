using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Parameters;
using Dealership.Factories;
using Dealership.Engine;
using Dealership.Contracts;
using Dealership.Models;

namespace Dealership.Ninject
{
    public class DealershipModule : NinjectModule
    {
        private const string CarName = "Car";
        private const string MotorcycleName = "Motorcycle";
        private const string TruckName = "Truck";
        private const string CommentName = "Comment";
        private const string CommandName = "Command";
        private const string UserName = "User";
        private const string ReaderName = "SomeReader";
        private const string WriterName = "SomeWriter";

        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterfaces();
            });

            this.Bind<IReader>().To<SomeReader>().Named(ReaderName);
            this.Bind<IWriter>().To<SomeWriter>().Named(WriterName);
            this.Bind<IUser>().To<User>().Named(UserName);
            this.Bind<IVehicle>().To<Car>().Named(CarName);
            this.Bind<IVehicle>().To<Motorcycle>().Named(MotorcycleName);
            this.Bind<IVehicle>().To<Truck>().Named(TruckName);
            this.Bind<ICommand>().To<Command>().Named(CommandName);
            this.Bind<IComment>().To<Comment>().Named(CommentName);
            this.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();
            this.Bind<IDealershipFactory>().ToFactory();
        }
    }
}