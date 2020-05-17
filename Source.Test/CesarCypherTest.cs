using System;
using Xunit;

namespace Codenation.Challenge
{
    public class CesarCypherTest
    {
        [Fact]
        public void Should_Not_Accept_Null_When_Crypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentNullException>(() => cypher.Crypt(null));
        }

        [Fact]
        public void Should_Return_Only_Blank_Spaces_When_Crypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("     ", cypher.Crypt("     "));
        }

        [Fact]
        public void Should_Not_Accept_Special_Characteres_When_Crypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentOutOfRangeException>(() => cypher.Crypt("><!@#*&%"));
        }

        [Fact]
        public void Should_Not_Accept_Accentuation_When_Crypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentOutOfRangeException>(() => cypher.Crypt("âãàáêẽèéîĩìíôõòóûũùú"));
        }

        [Fact]
        public void Should_Keep_Numbers_Out_When_Crypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("d1e2f3g4h5i6j7k8l9m0", cypher.Crypt("a1b2c3d4e5f6g7h8i9j0"));
        }

        [Fact]
        public void Should_Crypt_Message()
        {
            var cypher = new CesarCypher();
            Assert.Equal("wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj", cypher.Crypt("the quick brown fox jumps over the lazy dog"));
        }

        [Fact]
        public void Should_Not_Accept_Null_When_Decrypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentNullException>(() => cypher.Decrypt(null));
        }

        [Fact]
        public void Should_Return_Only_Blank_Spaces_When_Decrypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("     ", cypher.Decrypt("     "));
        }

        [Fact]
        public void Should_Not_Accept_Special_Characteres_When_Decrypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentOutOfRangeException>(() => cypher.Decrypt("><!@#*&%"));
        }

        [Fact]
        public void Should_Not_Accept_Accentuation_When_Decrypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentOutOfRangeException>(() => cypher.Decrypt("âãàáêẽèéîĩìíôõòóûũùú"));
        }

        [Fact]
        public void Should_Keep_Numbers_Out_When_Decrypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("a1b2c3d4e5f6g7h8i9j0", cypher.Decrypt("d1e2f3g4h5i6j7k8l9m0"));
        }

        [Fact]
        public void Should_Decrypt_Message()
        {
            var cypher = new CesarCypher();
            Assert.Equal("the quick brown fox jumps over the lazy dog", cypher.Decrypt("wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj"));
        }
    }
}
