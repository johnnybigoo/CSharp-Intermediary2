using System;
namespace Tamus.Entities
{
    public class Medico : Funcionario
    {

        private string crm, especializacao;
        public string Crm { get => crm; set => crm = value; }
        public string Especializacao { get => especializacao; set => especializacao = value; }

        public void calculaSalario(int horasTrabalhadas, double valorDaHora)
        {
            salario = horasTrabalhadas + valorDaHora;
        }

        /*
         + calculaSalario(int horasTrabalhadas, double valorDaHora): void
         
         */

    }
}
