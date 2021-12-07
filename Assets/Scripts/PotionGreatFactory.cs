class PotionGreatFactory : PotionFactory
{
	private int _owned;

	public PotionGreatFactory(int owned)
	{
		_owned = owned;
	}

	public override Potion GetPotion()
	{
		return new PotionGreat(_owned);
	}
}