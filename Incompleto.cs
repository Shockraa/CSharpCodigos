using System;

public class Program
{
	public static void Main()
	{
		Comanda controleMesa = new Comanda(); //Cria objeto
		Caixa caixa = new Caixa(); //Cria outro objeto
		int escolha = 5; //Declara um valor não ultilizado
		while (escolha != 0)
		{
			Console.WriteLine("Olá, escolha uma das opções:");
			Console.WriteLine("1 – Lançar gastos");
			Console.WriteLine("2 – Verificar promoção");
			Console.WriteLine("3 – Fechar mesa");
			Console.WriteLine("4 – Listar comanda");
			Console.WriteLine("0- Sair");
			escolha = int.Parse(Console.ReadLine());
			if (escolha == 1)
			{
				Comanda.lancarGastos();
			}

			if (escolha == 2)
			{
				Comanda.verificarPromocao();
			}

			if (escolha == 3)
			{
			}

			if (escolha == 4)
			{
			//Opção mostrar (ignorar)
			}
		}

		Console.WriteLine("Obrigado por usar!"); //Fim do programa
	}
}

public class Comanda
{
	private int id;
	private double valorConsumo;
	private double valorEstacionamento;
	private double valorCouvert;
	private double valorDescontoPromocional;
	private double valorTotal;
	
	public Comanda()
	{
		this.id = 0; //Exemplo
		this.valorConsumo = 0;
		this.valorEstacionamento = 0;
		this.valorCouvert = 0;
	}

	public Comanda(double valorConsumo, double valorEstacionamento, double valorCouvert)
	{
		this.valorDescontoPromocional = 0;
		this.valorTotal = 0;
		this.valorConsumo = valorConsumo;
		this.valorEstacionamento = valorEstacionamento;
		this.valorCouvert = valorCouvert;
	}
	public Comanda(int id)
	{
		this.id = 0;
	}

	public static void lancarGastos()
	{
		Console.WriteLine("Valor consumido?");
		double valorConsumo = double.Parse(Console.ReadLine());
		Console.WriteLine("Valor estacionamento?");
		double valorEstacionamento = double.Parse(Console.ReadLine());
		Console.WriteLine("Valor couvert?");
		double valorCouvert = double.Parse(Console.ReadLine());
		Comanda controleMesa = new Comanda(valorConsumo, valorEstacionamento, valorCouvert); //Segundo construtor
		Console.WriteLine("Os gastos foram lançados.");
	}

	public static void verificarPromocao()
	{
		if (this.valorConsumo > 100)
		{
			
		}
	}

	public static void listarComanda()
	{
	}
}

public class Caixa
{
	public static double totalizarComanda()
	{
	//ignorar
	}
}