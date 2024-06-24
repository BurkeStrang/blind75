namespace Blind75.Tests.ArraysAndHashing;

public class EncodeAndDecodeStringTests
{
    [Fact]
    public void EncodeAndDecodeStringTestsSimpleHelloWorld()
    {
        string[] input = ["hello", "world"];
        string encoded = Codec.Encode(input);
        IList<string> decoded = Codec.Decode(encoded);
        Assert.Equal(input, decoded);
    }

    [Fact]
    public void EncodeAndDecodeStringTestsEmptyString()
    {
        string[] input = [];
        string encoded = Codec.Encode(input);
        IList<string> decoded = Codec.Decode(encoded);
        Assert.Equal(input, decoded);
    }

    [Fact]
    public void EncodeAndDecodeStringTestsSingleString()
    {
        string[] input = ["hello"];
        string encoded = Codec.Encode(input);
        IList<string> decoded = Codec.Decode(encoded);
        Assert.Equal(input, decoded);
    }

    [Fact]
    public void EncodeAndDecodeStringTestsLongString()
    {
        string[] input = ["hello", "world", "this", "is", "a", "long", "string"];
        string encoded = Codec.Encode(input);
        IList<string> decoded = Codec.Decode(encoded);
        Assert.Equal(input, decoded);
    }
}
