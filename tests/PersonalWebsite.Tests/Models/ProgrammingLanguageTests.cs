using PersonalWebsite.Models;

namespace PersonalWebsite.Tests.Models;

public class ProgrammingLanguageTests
{
    [TestCase(ProgrammingLanguage.CSharp, "C#")]
    [TestCase(ProgrammingLanguage.CPlusPlus, "C++")]
    [TestCase(ProgrammingLanguage.Rust, "Rust")]
    [TestCase(ProgrammingLanguage.Python, "Python")]
    [TestCase((ProgrammingLanguage)10, "")]
    public void GetFormattedString_VariousInputs_ExpectedResponse(ProgrammingLanguage language, string expectedString)
    {
        var response = language.GetFormattedString();
        Assert.That(response, Is.EqualTo(expectedString));
    }

    [TestCase(ProgrammingLanguage.CSharp, "text-purple-500")]
    [TestCase(ProgrammingLanguage.CPlusPlus, "text-sky-500")]
    [TestCase(ProgrammingLanguage.Rust, "text-red-500")]
    [TestCase(ProgrammingLanguage.Python, "text-blue-500")]
    [TestCase((ProgrammingLanguage)10, "text-green-500")]
    public void GetColor_StartNotProvided_TextReturned(ProgrammingLanguage language, string expectedColorClass)
    {
        var color = language.GetColor();
        Assert.That(color, Is.EqualTo(expectedColorClass));
    }

    [TestCase(ProgrammingLanguage.CSharp, "bg-purple-500")]
    [TestCase(ProgrammingLanguage.CPlusPlus, "bg-sky-500")]
    [TestCase(ProgrammingLanguage.Rust, "bg-red-500")]
    [TestCase(ProgrammingLanguage.Python, "bg-blue-500")]
    [TestCase((ProgrammingLanguage)10, "bg-green-500")]
    public void GetColor_StartProvided_TextReturned(ProgrammingLanguage language, string expectedColorClass)
    {
        var color = language.GetColor("bg");
        Assert.That(color, Is.EqualTo(expectedColorClass));
    }
}