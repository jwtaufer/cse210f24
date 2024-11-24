using Microsoft.VisualBasic;

public class Library
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _randomScripture = new Random();

    public Library()
    {
        Reference alma = new Reference("Alma", 7, 11, 13);
        Scripture scripture1 = new Scripture(
            alma,
            "11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. \n\n12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. \n\n13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."
        );

        _scriptures.Add(scripture1);

        Reference ether = new Reference("Ether", 12, 27);
        Scripture scripture2 = new Scripture(
            ether,
            "27 And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
        );

        _scriptures.Add(scripture2);
    }

    public Scripture GetRandomScripture()
    {
        int i = _randomScripture.Next(_scriptures.Count);
        return _scriptures[i];
    }
}