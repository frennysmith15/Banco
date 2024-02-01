using System;

public class Banco
{
	private double dineroTotal;
	private Cliente cliente1, cliente2, cliente3;

	public Banco(Cliente cliente1, Cliente cliente2, Cliente cliente3, )
	{
		this.cliente1 = cliente1;
		this.cliente2 = cliente2;
		this.cliente3 = cliente3;
		this.dineroTotal = cliente1.getDeposito() + cliente2.getDeposito() + cliente3.getDeposito();
	}

	public double getDineroTotal() {  return dineroTotal; }
}


public class Cliente
{
	private string nombre;
	private string apellido;
	private double deposito;


	public Cliente(string nombre, string apellido, double deposito)
	{
		this.nombre = nombre;
		this.apellido = apellido; 
		this.deposito = deposito;
	}

	public void setDeposito(double deposito)
	{
		this.deposito = deposito;
	}

	public double getDeposito()
	{
		return this.deposito;
	}

}