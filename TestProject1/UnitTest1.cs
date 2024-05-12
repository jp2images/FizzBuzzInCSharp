using FizzBuzzInCSharp;

namespace TestProject1;

public class Tests
{
    private readonly FizzBuzz _fizzBuzz = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void test_should_return_number_for_integer()
    {
        // a simple example to start you off
        Assert.That(_fizzBuzz.Answer(), Is.EqualTo("2"));
    }

    [Test]
    public void test_should_return_fizz_when_three()
    {
        Assert.That(_fizzBuzz.ReturnFizz(3), Is.EqualTo("Fizz"));
    }

    [Test]
    public void test_should_return_fizz_when_five()
    {
        Assert.That(_fizzBuzz.ReturnBuzz(5), Is.EqualTo("Buzz"));
    }

    [Test]
    public void test_should_return_fizzBuzz_when_three_and_five()
    {
        Assert.That(_fizzBuzz.ReturnFizzBuzz(15), Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void test_should_fail_fizzBuzz_when_three_and_five()
    {
        Assert.That(_fizzBuzz.ReturnFizzBuzz(6), Is.Not.EqualTo("FizzBuzz"));
    }
}