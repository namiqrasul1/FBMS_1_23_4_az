class MyClass
{
	~MyClass() // Finalizer
	{
		Dispose();
	}

	public void Dispose()
	{
		// bla bla
		GC.SuppressFinalize(this);
	}

	static void Main(string[] args)
	{
        GC.Collect(0);
    }
}

