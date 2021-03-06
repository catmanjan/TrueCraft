using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Items
{
    public class BrickItem : ItemProvider
    {
        public static readonly short ItemID = 0x150;

        public override short ID { get { return 0x150; } }

        public override string DisplayName { get { return "Brick"; } }
    }
}