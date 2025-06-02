using System;

public class NewEdits
{
	public NewEdits()
	{
	}

	// MAke new delegate for the new edits
	public delegate void NewEditDelegate(string message);

	// Method to be called by the delegate
	public void DisplayMessage(string message)
	{
		Console.WriteLine(message);
	}


	public void ExecuteDelegate(NewEditDelegate newEditDelegate, string message)
	{
		newEditDelegate(message);
	}
}
