namespace TodoApi.Models{
    public class TodoItem
    {
        public long Id{get; set;}
        public string? Name{get; set;}
        public bool IsComplete{get; set;}
        /*DTO可用來：
            防止過度張貼。
            隱藏用戶端不應該檢視的屬性。
            省略一些屬性，以減少承載大小。
            包含巢狀物件的壓平合併物件圖形。 壓平合併物件圖形對用戶端會更方便。
        */
        public string? Secret{get; set;}
    }
}

