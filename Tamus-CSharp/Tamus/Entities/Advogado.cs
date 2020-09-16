using System;
namespace Tamus.Entities
{
    public class Advogado : Funcionario
    {
        
        private string especializacao;
        private string oab;

        protected string Oab { get => oab; set => oab = value; }
        protected string Especializacao { get => especializacao; set => especializacao = value; }

        public void calculaSalario(int horasTrabalhadas, double valorDahora, int casosVencidos)
        {
            
        }
        /*
         + calculaSalario(int horasTrabalhadas, double valorDaHora, int casosVencidos): void
         
         */

    }
            
}

        
   

