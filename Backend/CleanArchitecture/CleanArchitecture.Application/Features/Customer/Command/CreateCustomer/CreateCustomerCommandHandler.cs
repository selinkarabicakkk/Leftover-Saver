using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.Customer.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler
    {

        private ICustomerRepositoryAsync customerRepository;
       // private IEmailService emailService;

        public async Task <string> Handle(CreateCustomerCommand request)
        {
           Entities.Customer existingCustomer=await customerRepository.GetByEmail(request.Email);

            if(existingCustomer!= null)
            {
                throw new Exception($"User with email {request.Email} has already exists.");
            }
            var customer = await customerRepository.AddAsync(new Entities.Customer
            {
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Password = request.Password,
               // isEnabled = true,

            }) ;
            return customer.UserName;
        }


    }
}