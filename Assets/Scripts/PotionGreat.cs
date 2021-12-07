
	
	class PotionGreat : Potion
	{
		private readonly string _type;
		private int _heal;
		private int _owned;
		
		public PotionGreat(int amountOwned)  
		{
			_type = "PotionGreat";
			_heal = 50;
			_owned = amountOwned;
		}  
  
		public override string type  
		{  
			get { return type; }  
		}  
  
		public override int heal  
		{  
			get { return _heal; }  
		}  
  
		public override int owned  
		{  
			get { return _owned; }  
			set { _owned = value; }  
		}  

	}
	
