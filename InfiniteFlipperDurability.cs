using System.Linq;
using UnityEngine;

[ModTitle("Infinite Flipper Durability")]
[ModDescription("Inspired and written for𝓐𝓷𝓰𝓮𝓵 𝓢𝓴𝔂𝓱𝓮𝓪𝓻𝓽, making the flipper durability infinite while using.")]
[ModAuthor("SWiRaki")]
[ModIconUrl("")]
[ModWallpaperUrl("")]
[ModVersionCheckUrl("")]
[ModVersion("1.0")]
[RaftVersion("11.0")]
[ModIsPermanent(false)]
public class InfiniteFlipperDurability : Mod
{
    public void Start()
    {
        RConsole.Log("InfiniteFlipperDurability has been loaded!");
    }
    
    public void Update()
    {
        try
        {
            foreach (Slot eqipment in RAPI.GetLocalPlayer().Inventory.equipSlots.Where(x => x.HasValidItemInstance()))
                if (eqipment.itemInstance.UniqueIndex == 63 && eqipment.itemInstance.Uses < 600)
                    eqipment.SetUses(600);
        }
        catch
        { return; }
    }
    
    public void OnModUnload()
    {
        RConsole.Log("InfiniteFlipperDurability has been unloaded!");
        Destroy(gameObject);
    }
}
