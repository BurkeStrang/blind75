public class EncodeAndDecodeStringTests
{
    [Fact]
    public void EncodeAndDecodeStringTestsSimpleHelloWorld()
    {
        string[] input = new string[] { "hello", "world" };
        string encoded = Codec.Encode(input);
        IList<string> decoded = Codec.Decode(encoded);
        Assert.Equal(input, decoded);
    }
}
