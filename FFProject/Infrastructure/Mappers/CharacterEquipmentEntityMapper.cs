using Domain.Entities;
using Infrastructure.Entities;

namespace Infrastructure.Mappers;

/// <summary>
/// Mapper for mapping infrastructure characterEquipment entity to domain characterEquipment entity
/// </summary>
public class CharacterEquipmentEntityMapper
{
    public CharacterEquipment Map(CharacterEquipmentEntity infrastructureCharacterEquipment)
    {
        return new CharacterEquipment
        {
            UserId = infrastructureCharacterEquipment.UserId,
            ArmourId = infrastructureCharacterEquipment.ArmourId,
            AccessoryId = infrastructureCharacterEquipment.AccessoryId,
            CharacterId = infrastructureCharacterEquipment.CharacterId,
            WeaponId = infrastructureCharacterEquipment.WeaponId,
            ShieldId = infrastructureCharacterEquipment.ShieldId
        };
    }
}