/* this is generated by nino */
namespace Nino.Benchmark.Models
{
    public partial class AccountMerge
    {
        public static AccountMerge.SerializationHelper NinoSerializationHelper = new AccountMerge.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<AccountMerge>
        {
            #region NINO_CODEGEN
            public override void Serialize(AccountMerge value, Nino.Serialization.Writer writer)
            {
                writer.CompressAndWrite(value.OldAccountId);
                writer.CompressAndWrite(value.NewAccountId);
                writer.Write(value.MergeDate);
            }

            public override AccountMerge Deserialize(Nino.Serialization.Reader reader)
            {
                AccountMerge value = new AccountMerge();
                value.OldAccountId =  (System.Int32)reader.DecompressAndReadNumber();
                value.NewAccountId =  (System.Int32)reader.DecompressAndReadNumber();
                value.MergeDate = reader.ReadDateTime();
                return value;
            }
            #endregion
        }
    }
}