class PotionBadFactory : PotionFactory
{
	private int _owned;

	public PotionBadFactory(int owned)
	{
		_owned = owned;
	}

	public override Potion GetPotion()
	{
		return new PotionBad(_owned);
	}
}