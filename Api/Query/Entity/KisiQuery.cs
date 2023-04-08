namespace Api.Query.Entity
{
    public class KisiQuery
    {
        public const string GetKisiListesiSql = @"SELECT * FROM Kisi";

        public const string GetKisiId = @"SELECT * FROM Kisi WHERE Id = @Id";

        public const string InsertKisi = @"
        INSERT INTO [dbo].[Kisi]
           ([Adi]
           ,[Soyadi]
           ,[Yas]
           ,[AktifMi])
        OUTPUT INSERTED.*
        VALUES
           (@Adi,
           @Soyadi,
           @Yas,
           @AktifMi)
        ";

        public const string UpdateKisi = @"
        UPDATE [dbo].[Kisi]
        SET [Adi] = @Adi
          ,[Soyadi] = @Soyadi
          ,[Yas] = @Yas
          ,[AktifMi] = @AktifMi
        OUTPUT INSERTED.*
        WHERE Id = @Id
        ";

        public const string DeleteKisi = @"DELETE FROM [dbo].[Kisi] WHERE Id = @Id";
    }
}
