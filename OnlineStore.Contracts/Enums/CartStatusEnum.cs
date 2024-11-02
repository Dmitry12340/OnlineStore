using System.ComponentModel;

namespace OnlineStore.Contracts.Enums
{
    public enum CartStatusEnum
    {
        [Description("Новая")]
        New = 1,

        [Description("Оформлена")]
        Done = 2,
    }
}
