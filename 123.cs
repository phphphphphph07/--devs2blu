namespace aula_15_10
{
    public class Carro
    {
        public const int VELOCIDADE_MAXIMA = 80;
        public const int PORCENTAGEM_RESERVA = 20;
        public string Modelo;
        public int Ano;
        public int TanqueAtual;
        public int TanqueLimite;

        private int Velocidade = 50;
        private int _velocidade
        {
            get
            {
                if (Velocidade > VELOCIDADE_MAXIMA)
                {
                    return VELOCIDADE_MAXIMA;
                }
                return Velocidade;
            }
        }
        //ctor + TAB
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public Carro()
        {

        }

        public Carro(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public void Info()
        {
            Console.WriteLine($"Carro de modelo {Modelo} e ano {Ano} e a velocidade está em {_velocidade}");
        }


        //public void Acelerar(int velocidade, out int velocidadeAtual)
        //{
        //    _velocidade += velocidade;
        //    velocidadeAtual = Velocidade;
        //}



        public bool Reserva()
        {
            var porcentagemLimite = (TanqueLimite / 100) * PORCENTAGEM_RESERVA;
            Console.WriteLine("Dados do tanque");
            Console.WriteLine($"20% = {porcentagemLimite}");
            Console.WriteLine($"Atual = {TanqueAtual}");

            return TanqueAtual < porcentagemLimite;
        }

    }



    public class Mamífero
    {
        public string Nome;
        public string NomeCientífico;
        public int Idade;

        public void Info()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nome: {NomeCientífico}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }

    public class Livro
    {
        public string Título;
        public string Autor;

        public void Info()
        {
            Console.WriteLine($"Titulo: {Título}");
            Console.WriteLine($"Autor: {Autor}");
        }
    }

    public class Calculadora
    {
        public int PrimeiroNúmero;
        public int SegundoNúmero;

        public void Somar()
        {
            int Resultado = PrimeiroNúmero + SegundoNúmero;
            Console.WriteLine($"Resultado {Resultado}");
        }

        public void Subtrair()
        {
            int Resultado = PrimeiroNúmero - SegundoNúmero;
            Console.WriteLine($"Resultado {Resultado}");

        }

        public void Multiplicar()
        {
            int Resultado = PrimeiroNúmero * SegundoNúmero;
            Console.WriteLine($"Resultado {Resultado}");
        }

        public void Dividir()
        {
            int Resultado = PrimeiroNúmero / SegundoNúmero;
            Console.WriteLine($"Resultado {Resultado}");
        }



    }


    public class Aluno
    {
        public string Nome;
        public int Idade;
        public string Matrícula;

        public void CalcularidadeEmMeses()
        {
            int idadeAluno = Idade * 12;
            Console.WriteLine($"Idade em Meses: {idadeAluno}");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matricula: {Matrícula}");
        }



    }

    public class ContaBancaria
    {
        public int QtdContas { get => _QtdContas; }
        private int _QtdContas = 0;
        public string Titular;
        public double Saldo;
        //public static int _ContasCadastradas = 0;
        //public static int ContasCadastradas { get => _ContasCadastradas; }

        public ContaBancaria()
        {
            _QtdContas++;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito bem sucedido");
        }
        public void Sacar(double valor)
        {

            if (valor > Saldo)
            {
                Console.WriteLine("Saque indisponível!");
            }
            if (valor < Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Seu saque foi bem sucedido!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine(Titular);
            Console.WriteLine(Saldo);
        }

    }

    public class Produto
    {
        private string Nome;
        private decimal Preco;


        public void AlterarNome(string nome)
        {
            Nome = nome;
            Console.WriteLine("Nome alterado");
        }

        public void AlterarPreco(int preco)
        {
            if (preco > 0)
            {
                Preco = preco;
                Console.WriteLine("Preço alterado");
            }
            else
            {
                Console.WriteLine("Preço não alterado");
            }
        }
        public override string ToString()
        {
            return $"Dados do Produto\nNome: {Nome};\nPreço: {Preco}";
        }
    }

    public class Pessoa
    {
        private static int _ContagemPessoasCadastradas = 0;

        public static int ContagemPesoasCadastradas { get => _ContagemPessoasCadastradas; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _ContagemPessoasCadastradas++;
        }



    }



    public enum DiasSemana
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7
    }

    public class Veículo
    {
        public int Velocidade { get; set; }
    
    
        public void Mover()
        {
            Console.WriteLine("O veículo está se movendo");
        }
    }


    public class Carro2 : Veículo
    {
        public int QtdPortas { get; set; }

        public void Buzinar()
        {
            Console.WriteLine("Bee!");
        }
    }

    public class Animal
    {
        protected string Som { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine($"Seu animal está emetindo um som: {Som}");
        }

    }

    public class Gato : Animal
    {
        public Gato()
        {
        Som = "miau";
        }
        
    }

    public class Cachorro : Animal
    {
        
        public Cachorro()
        {
            Som = "Au";
        }
    }

    public class Marreco : Animal
    {

        public Marreco()
        {
            Som = "Quack";
        }
    }

    public class InstrumentoMusical
    {
        protected string Som { get; set; }
        public void Tocar()
        {
            Console.WriteLine($"O instrumento está fazendo {Som}");
        }
    }

    public class Saxofone : InstrumentoMusical
    {
        public Saxofone() 
        {
            Som = "Assopre o saxofone";
        }
    }


    public class Violão : InstrumentoMusical
    {
        public Violão() 
        {
            Som = "BLEM";   
        }
    }

    public class Piano : InstrumentoMusical
    {
        public Piano() { Som = "DIM"; }

    }

    public class Tambor : InstrumentoMusical
    {
        public Tambor() { Som = "BUM"; }
    }
  
    
    public abstract class RegistroDB
    {

        protected abstract string NomeTabela {get;set;} 

        public void Select()
        {
            var select = $"SELECT * FROM {NomeTabela}";

            Console.WriteLine($"Executando select no banco de dados: {select}");
        }

    }
    
    
    //public class PessoaDB : RegistroDB
    //{
    //    protected override string NomeTabela { get => "PESSOAS"; }
    //}
    
    public abstract class CalcularPerimetro
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public abstract void Perimetro();

    }

    public class Retangulo : CalcularPerimetro
    {
        public Retangulo(int@base, int altura)
        {
            Base = @base
                ; Altura = altura;
        }

        public override void Perimetro()
        {
            Console.WriteLine($"O resultado do cáculo é {Base * Altura}");
        }


    }






    public interface IMotor
    {
        void Ligar();
        void Desligar();
    }


    public interface ICambioManual
    {
        void ColocarMarchaAcima();
        void ColocarMarchaAbaixo();
    }

    public class Gol : Carro, IMotor, ICambioManual
    {

        public void ColocarMarchaAbaixo()
        {
            Console.WriteLine("");
        }
        public void Desligar()
        {
            Console.WriteLine("");
        }


        public void ColocarMarchaAcima()
        { 
            Console.WriteLine("");
        }

        public void Ligar()
        { }

    }


    public interface IAutenticavel
    {
        void Autenticar();
        void Deslogar();

    }

    public class UsuarioSistema : IAutenticavel
    {
        public void Autenticar()
        {
            Console.WriteLine();
        }
        public void Deslogar()
        {
            Console.WriteLine();
        }
    }










    public class Executor
    {
        public static void Executar()
        {






            //var triangulo = new Retangulo();
            //triangulo.Base = 1;
            //triangulo.Altura = 4;

            //triangulo.Perimetro();











            //var registro = new PessoaDB();

            //registro.Select();






            //var instrumentos = new InstrumentoMusical[3];
            
            
            //foreach ( var instrumento in instrumentos )
            //{
            //    instrumento.Tocar();
            //}


            //List<Animal> animais = new List<Animal>();

            //animais.Add(new Cachorro());
            //animais.Add(new Gato());
            //animais.Add(new Cachorro());
            //animais.Add(new Gato());
            //animais.Add(new Gato());
            //animais.Add(new Marreco());

            //foreach (var animal in animais)
            //{
            //    animal.EmitirSom();
            //}

            //var a1 = new Gato();
            //var a2 = new Cachorro();

            //a1.EmitirSom();


            //a2.EmitirSom();

            //var carro = new Carro2();

            //carro.Mover();
            //carro.Buzinar();



            //var p1 = new Produto();


            //p1.AlterarNome("Geladeira");
            //p1.AlterarPreco(1000);

            //Console.WriteLine(p1.ToString);










            //DiasSemana numero = (DiasSemana)2;

            //switch (numero)
            //{
            //    case DiasSemana.Domingo:
            //        Console.WriteLine("É Domingo");
            //        break;
            //    case DiasSemana.Segunda:
            //        Console.WriteLine("É Segunda");
            //        break;
            //    case DiasSemana.Terca:
            //        Console.WriteLine("É Terça");
            //        break;
            //    case DiasSemana.Quarta:
            //        Console.WriteLine("É Quarta");
            //        break;
            //    case DiasSemana.Quinta:
            //        Console.WriteLine("É Quinta");
            //        break;
            //    case DiasSemana.Sexta:
            //        Console.WriteLine("É Sexta");
            //        break;
            //    case DiasSemana.Sabado:
            //        Console.WriteLine("É Sábado");
            //        break;
            //    default:
            //        break;

            //}




            //var p1 =new Produto();
            //p1.Preco = 1568.24;




            //var b1 = new ContaBancaria();
            //var b2 = new ContaBancaria();
            //var b3 = new ContaBancaria();
            //var b4 = new ContaBancaria();


            //Console.WriteLine($"Existem {ContaBancaria._QtdContas} pessoas cadastrdas no banco");


            //Console.WriteLine($"Existem {Pessoa.ContagemPesoasCadastradas} pessoas cadastradas no sistema");
            //var p1 = new Pessoa()
            //{
            //    Nome = "João",
            //    Idade = 18
            //};

            //var p2 = new Pessoa()
            //{
            //    Nome = "Ana",
            //    Idade = 16
            //};
            //var p3 = new Pessoa()
            //{
            //    Nome = "Maria",
            //    Idade = 17
            //};

            //Console.WriteLine($"Existem {Pessoa.ContagemPesoasCadastradas} pessoas cadastradas no sistema");







            //var aluno1 = new Aluno()
            //{
            //    Idade = 12,
            //    Nome = "Sérgio",
            //    Matrícula = "1292103",
            //};

            //aluno1.ExibirInfo();
            //aluno1.CalcularidadeEmMeses();












            //var carro1 = new Carro();
            //carro1.Modelo = "Clio";
            //carro1.Ano = 1995;
            //carro1.TanqueLimite = 100;
            //carro1.TanqueAtual = 21;
            //carro1.Acelerar(25);
            //carro1.Info();

            //    var carro2 = new Carro()
            //    {
            //        Modelo = "HB20",
            //        Ano = 2022,
            //        TanqueLimite = 100,
            //        TanqueAtual = 22,
            //    };

            //    var carro3 = new Carro("Fusca" , 1976);

            //    var carro4 = new Carro("Gol");

            //    carro1.Info();
            //    Console.WriteLine(string.Empty);
            //    carro2.Info();
            //    Console.WriteLine(string.Empty);
            //    carro3.Info();
            //    Console.WriteLine(string.Empty);
            //    carro4.Info();

            //    Console.WriteLine(string.Empty);


            //ExibirMensagemConsole("Olá");
            //Console.WriteLine(Somar(5, 5 , 36));
        }
        //public static void ExibirMensagemConsole(string mensagem)
        //{
        //    Console.WriteLine(mensagem);
        //}

        //public static int Somar(params int[] numeros)
        //{
        //    int resultado = 0;

        //    foreach (int numero in numeros) 
        //    {
        //        resultado += numero;
        //    }

        //    return resultado;
        //}

        //    var carro = new Carro();
        //    carro.Modelo = "Clio";
        //    carro.Ano = 1995;
        //    carro.TanqueAtual = 10; 
        //    carro.TanqueLimite = 1000;
        //    //Console.WriteLine($"Carro de modelo {carro.Modelo} e ano {carro.Ano}");

        //    carro.Info();
        //    Console.WriteLine($"O carro {(carro.Reserva() ? "Sim" : "NÂO")} está na reserva!");

        //var mamífero = new Mamífero();
        //    mamífero.Idade = 4;
        //    mamífero.Nome = "Coda";
        //    mamífero.NomeCientífico = "";


        //    mamífero.Info();


        //var livro = new Livro();
        //    livro.Autor = "Pablo";
        //    livro.Título = "Todos"; 

        //    livro.Info();

        //Console.WriteLine("Digite qual operação voce quer usar:");
        //Console.WriteLine("1- Somar");
        //Console.WriteLine("2- Subtrair");
        //Console.WriteLine("3- Multiplicar");
        //Console.WriteLine("4- Dividir");
        //int escolha = int.Parse( Console.ReadLine() );
        //Console.WriteLine("Digite o primeiro número que você que utilizar");
        //int numero1 = int.Parse( Console.ReadLine() );
        //Console.WriteLine("Digite o segundo número que você que utilizar");
        //int numero2 = int.Parse( Console.ReadLine() );  

        //var calculadora = new Calculadora();
        //calculadora.PrimeiroNúmero = numero1;
        //calculadora.SegundoNúmero = numero2;

        //if (escolha == 1)
        //{
        //    calculadora.Somar();
        //}

        //if (escolha == 2) 
        //{
        //    calculadora.Subtrair();
        //}

        //if(escolha == 3)
        //{
        //    calculadora.Multiplicar();
        //}

        //if (escolha == 4) 
        //{
        //    calculadora.Dividir();
        //    





    }
}


