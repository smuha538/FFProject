using Application.Models;
using Domain.Entities;

namespace Application.Mappers.ModelMappers;

/// <summary>
/// Mapper for mapping domain characterEquipment entity to characterEquipment model entity
/// </summary>
public class CharacterEquipmentModelMapper
{
    public CharacterEquipmentModel Map(CharacterEquipment characterEquipment)
    {
        return new CharacterEquipmentModel
        {
            UserId = characterEquipment.UserId,
            ArmourId = characterEquipment.ArmourId,
            AccessoryId = characterEquipment.AccessoryId,
            CharacterId = characterEquipment.CharacterId,
            WeaponId = characterEquipment.WeaponId,
            ShieldId = characterEquipment.ShieldId
        };
    }
}