using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.ViewModel;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;

        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccTransfer _AccTransfer)
        {//from to am
            var _CreateTransferCommand = new CreateTransferCommand(
                _AccTransfer.FromAccount,
                _AccTransfer.ToAccoun, 
                _AccTransfer.TransferAmoun);
            _bus.SendCommand(_CreateTransferCommand);
        }
    }
}
