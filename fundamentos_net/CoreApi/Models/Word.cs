namespace CoreApi.Models{
    public class Word:BaseEntity{
        
        public string WordFrom{get;set;}
        public string WordTo{get;set;}
        public int IdUser{get;set;}
        public virtual User User{get;set;}
    }
}