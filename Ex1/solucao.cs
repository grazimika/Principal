﻿using System;
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

            swicth(codigo)
                {
                case 1
                    preco =16:
                break;
                case 2:
                    preco = 25;
                break;
                case 3:
                    preco = 20;
                break;
                case 4:
                    preco = 6.5;
                break;
                case 5:
                    preco = 8;
                break;
                }
                valor = preco * quantidade;

                Console.WriteLine("O valor da conta é R${0}", valor);
        }public void ex4()
        {
            Console.WriteLine("2.2");
            double a,b.c,x1,x2,delta,raiz;

            Console.WriteLine("Digite o numero : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero : ");
            double c = double.Parse(Console.ReadLine());

            delta=(b*b)-(4*a*c);
            if(delta>0 && a=0)
                Console.WriteLine("A equação não possui raízes");
            else
                double raiz = Math.Sqrt(delta)
                x1=((-b)+raiz)/(2*a);
                x2=((-b)-raiz)/(2*a);
            Console.WriteLine("Valor de x1:{0} e valor de x2:{1}",x1,x2)
        }public void ex5()
        {
            Console.WriteLine("Exercicio 3.1")
            string senha;
            Console.WriteLine("Digite a senha: ");
            string senha = string.Parse(Console.ReadLine());

            while (senha != "cotil")
            {
                Console.WriteLine("Senha incorreta");
            }
            Console.WriteLine("Acesso permitido");
               
        }public void ex6()
        {
            Console.WriteLine("Exercicio 3.2")
            int N,X;

            Console.WriteLine("Digite um numero: ");
            int N= int.Parse(Console.ReadLine());

            for(N=0;N<N;N++)
                int X=int.Parse(Console.ReadLine());
            break;
            if(X<=10)
                for(int Y =0; Y<N;Y++)
                    int Z++;
                    Console.WriteLine("{0}in",z);
            else
                int m++;
                     Console.WriteLine("{0}out",m);
        }public void ex7()
        {
            Console.WriteLine("Exercicios de Estrutura sequencial");
            Console.WriteLine("Exercicio 1")
            int a,b,soma;
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            soma=a+b;
            Console.WriteLine("Soma={0}",soma);
            Console.WriteLine("Exercicio 2 igual da Prova de logica de programação");
        }
        public void ex8()
        {
            Console.WriteLine("Exercicio 3");
            int a,b,c,d,diferenca;
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            int d=int.Parse(Console.ReadLine());

            diferenca = (a*b)-(c*d);
            Console.WriteLine("Diferença={0}",diferenca);

        }public void ex9()
        {
            int numero,hrs;
            float vlrH,salario;

            Console.WriteLine("Digite o número do funcionário: ");
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int hrs=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: ");
            int vlrH=float.Parse(Console.ReadLine());
            salario=hrs*vlrH;   
            Console.WriteLine("Número:{0} \n Salário: R${1}",numero,salario);
            Console.WriteLine("Exercicio 5 igual ao da prova diagnostica");
        }public void ex10()
        {
            double a,b,c,triangulo,circulo,trapezio,quadrado,retangulo;
            Console.WriteLine("Digite três valores: ");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());

            triangulo=(a*c)/2;
            circulo=(c*c)*3.14159;
            trapezio=((a+b)*c)/2;
            quadrado = b*b;
            retangulo = a*b;

            Console.WriteLine("Triangulo{0},circulo{1},trapezio{2},qudrado{3},retangulo{4}");

        }



      
 
          


    }
}

