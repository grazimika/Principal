using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class solucao
    {
        public void ex1()
        {
            int cp1;
            int qp1;
            float pu1;
            int cp2;
            int qp2;
            float pu2;
            float vlrPagar;

            Console.WriteLine("Exercicio 1.1");
            Console.WriteLine("PEÇA 1");
            cp1 = int.Parse(Console.ReadLine());
            qp1 = int.Parse(Console.ReadLine());
            pu1 = float.Parse(Console.ReadLine());

            Console.WriteLine("PEÇA 2");
            cp2 = int.Parse(Console.ReadLine());
            qp2 = int.Parse(Console.ReadLine());
            pu2 = float.Parse(Console.ReadLine());

            vlrPagar = (qp1 * pu1) + (qp2 * pu2);
            Console.WriteLine("Valor a ser pago: R$ {0:F2}", vlrPagar);
        }
        public void ex2()
        {
            Console.WriteLine("Exercicio 1.2");
            double raio;
            double area;
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("O valor da area é: {0:F4}", area);
        }
        public void ex3()
        {
            Console.WriteLine("Exercicio 2.1");
            int quantidade;
            float preco, valor;

            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            if (codigo = 1)
            {
                preco = 16;
            }else
            if(codigo = 2)
            {
                preco = 25;
            }else
            if(codigo = 3)
            {
                preco = 20;
            }else
            if(codigo = 4)
            {
                preco = 6.5;
            }else
            if(codigo = 5)
            {
                preco = 8;
            }
            valor = preco * quantidade;

            Console.WriteLine("O valor da conta é R${0}", valor);



        }

        
    
    }
}
