using System;

public enum Rating
{ 
	Good, 
	Great, 
	Excellent
};

public struct Dog
{
	public Dog(string nameV, float ageV, string ownerV, Rating ratingV)
    {
        name = nameV;
        age = ageV;
        owner = ownerV;
        rating = ratingV;
    }
    public string name;
    public float age;
	public string owner;
	public Rating rating;
}
