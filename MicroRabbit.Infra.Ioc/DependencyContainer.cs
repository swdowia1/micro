using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application;
using MicroRabbit.Transfer.Data;
using MicroRabbit.Transfer.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            //domain banking
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            //application services

            services.AddTransient<IAccountService, AccountService>();

            services.AddTransient<ITransferService, TransferService>();
            //data
            //ITransferRepository
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingContext>();
            services.AddTransient<TransferDBContext>();

        }
    }
}
