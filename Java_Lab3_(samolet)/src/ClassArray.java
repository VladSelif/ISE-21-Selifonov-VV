
class ClassArray<T> {
	
	private T ITransport;
	private ITransport[] cells;
	private ITransport defaultValue;

	public ClassArray(int sizes, ITransport defVal)
	{
		defaultValue = defVal;
		cells = new ITransport[sizes];
		for(int i = 0; i < cells.length; i++)
		{
			cells[i] = defaultValue;
		}
	}

	public ITransport getObject(int ind)
	{
		if(ind > -1 && ind < cells.length)
		{
			return cells[ind];
		}
		return defaultValue;
	}

	public static int Plus(ClassArray<ITransport> p, ITransport airplane)
	{
		for (int i = 0; i < p.cells.length; i++)
		{
			if (p.CheckFreePlace(i))
			{
				p.cells[i] = airplane;
				return i;
			}
		}
		return -1;
	}

	public static ITransport Minus(ClassArray<ITransport> p, int index)
	{
		if (!p.CheckFreePlace(index))
		{
			ITransport airplane = p.cells[index];
			p.cells[index] = p.defaultValue;
			return airplane;
		}
		return p.defaultValue;
	}

	private boolean CheckFreePlace(int index)
	{
		if (index < 0 || index > cells.length)
		{
			return false;
		}
		if (cells[index] == null)
		{
			return true;
		}
		if (cells[index].equals(defaultValue))
		{
			return true;
		}
		return false;
	}


	public T getITransport() {
		return ITransport;
	}

	
	public void setITransport(T iTransport) {
		ITransport = iTransport;
	}
}