using System;
using FluentValidation;
using HBSIS.Domain.Models;

namespace HBSIS.Domain.Entities
{
    public class Cliente : Entity<Cliente>
    {
        //EF Construtor
        protected Cliente() { }

        public Cliente(Guid id, string nome, string cpfCnpj, string telefone)
        {
            Id = id;
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string CpfCnpj { get; private set; }
        public string Telefone { get; private set; }

        public override bool IsValid()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do evento precisa ser fornecido.")
                .Length(2, 150).WithMessage("O nome do evento precisa ter entre 2 e 150 caracteres.");

            RuleFor(c => c.CpfCnpj)
                .NotEmpty().WithMessage("O CPF/CNPJ precisa ser fornecido.")
                .Length(11, 14).WithMessage("Se for CPF precisa ter 11 caracteres, para CNPJ precisa ter 11 caracteres.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("O Telefone precisa ser fornecido.")
                .Length(10, 16).WithMessage("O Telefone precisa ter no mínimo 10 caracteres.");
            
            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}