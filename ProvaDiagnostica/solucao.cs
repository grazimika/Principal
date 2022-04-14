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
            double raio, area;
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
             double preco;
             double valor;

             Console.WriteLine("Digite o codigo: ");
             int codigo = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite a quantidade: ");
             quantidade = int.Parse(Console.ReadLine());

             switch(codigo)
             { 
             case 1:
                  preco = 16;
                     valor = preco * quantidade;
                     Console.WriteLine("O valor é: R${0:F2}", valor);
                     break;
             case 2:
                 preco = 25;
                     valor = preco * quantidade;
                     Console.WriteLine("O valor é: R${0}", valor);
                     break;
             case 3:
                 preco = 20;
                     valor = preco * quantidade;
                     Console.WriteLine("O valor é: R${0}", valor);
                     break;
             case 4:
                     preco = 6.5;
                     valor = preco * quantidade;
                     Console.WriteLine("O valor é: R${0}", valor);
                     break;
             case 5:
                 preco = 8;
                     valor = preco * quantidade;
                     Console.WriteLine("O valor é: R${0}", valor);
                     break;
             }
        }
        public void ex4()
        {
             Console.WriteLine("2.2");
             double a,b,c,x1,x2,delta,raiz=0,raiz1;
             Console.WriteLine("Digite o numero : ");
              a = double.Parse(Console.ReadLine());
             Console.WriteLine("Digite o numero : ");
              b = double.Parse(Console.ReadLine());
             Console.WriteLine("Digite o numero : ");
              c = double.Parse(Console.ReadLine());

             delta=(b*b)-(4*a*c);
             if (delta < 0)
             {
                 Console.WriteLine("A equação não possui raízes");
             }
             else
             raiz = Math.Sqrt(delta);
                 x2 = (-b - raiz) / (2 * a);
                 x1 = (-b + raiz) / (2 * a); 
             if(raiz>0)
             Console.WriteLine("Valor de x1:{0} e valor de x2:{1}", x1, x2);
        }
        public void ex5()
        {
            Console.WriteLine("Exercicio 3.1");
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            while (senha != "cotil")
            {
                Console.WriteLine("Senha incorreta");
            }
                Console.WriteLine("Acesso permitido");
        }
    }
}

