namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Patino()
	{
		Assert.AreEqual(5, Program.Subtract("10", "5"));
	}

	[TestMethod]
	public void Subtract_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "5"));
	}

	[TestMethod]
	public void Subtract_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "5"));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Patino()
	{
		Assert.AreEqual(10, Program.Multiply("2", "5"));
	}

	[TestMethod]
	public void Multiply_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "b"));
	}

	[TestMethod]
	public void Multiply_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Patino()
	{
		Assert.AreEqual(2, Program.Divide("10", "5"));
	}

	[TestMethod]
	public void Divide_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("10", "x"));
	}

	[TestMethod]
	public void Divide_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "5"));
	}
}

[TestClass]
public class Powering
{
	[TestMethod]
	public void Power_Valid_Patino()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
	}

	[TestMethod]
	public void Power_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("2", "y"));
	}

	[TestMethod]
	public void Power_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
	}
}
