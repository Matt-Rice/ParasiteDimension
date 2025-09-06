# PD App Design Document

## Summary
This would be a basic desktop application that would be used foremost to set up battles, keep track of enemy stats, and streamline combat to make it easier on the DM.  

It will probably look pretty rough to start out with because functionality is more important than design, and I’m not used to making desktop apps.

---

## Features
- Enemy stat storage  
- Enemy list  
- Initiative tracker  
- Damage calculation  

---

## Battle Information
This section details the hierarchical structure of the information of the battle. The depth of the tabs shows which properties of a certain element are within another element (e.g., **HP** is a property of an **enemy**, which is a property of the **enemy list**, which is part of a **battle**).  

Battle data will be stored in a **local database** within the app.  

*Let me know if there’s anything you want me to add.*

---

### Battle
| Property                | Description   |
|--------------------------|---------------|
| Name of Battle (optional) | `name`        |
| Description (optional)    | `description` |

---

### Enemy List → Enemy
| Property        | Description             |
|-----------------|-------------------------|
| Photo           | *(maybe in the future)* |
| Name            | `name`                  |
| Description     | `description` *(optional)* |
| Max HP          | `value`                 |
| Current HP      | `value`                 |
| AP              | `value`                 |
| Armor           | `value`                 |
| Movement        | `value`                 |
| Max Wounds      | `value`                 |
| Current Wounds  | `value`                 |

---

### SWACKIE List → SWACKIE
| Property | Description |
|----------|-------------|
| Name     | `name`      |
| Value    | `value`     |

---

### Skill List → Skill
| Property | Description |
|----------|-------------|
| Name     | `name`      |
| Value    | `value`     |

---

### Attack List → Attack
| Property        | Description |
|-----------------|-------------|
| Name            | `name`      |
| Range           | `value`     |
| Damage          | `value`     |
| Max Ammo        | `value`     |
| Current Ammo    | `value`     |
| Description     | `value` *(optional)* |
| IsRanged        | `true/false` |
| IsMelee         | `true/false` |
| IsAOE           | `true/false` |

---

## Entity Relationship Diagram

```mermaid
erDiagram
    BATTLE ||--o{ ENEMY : "has"
    BATTLE ||--o{ SWACKIE : "has"
    ENEMY  ||--o{ SKILL : "has"
    ENEMY  ||--o{ ATTACK : "has"

    BATTLE {
        int BattleId
        string Name
        string Description
    }

    ENEMY {
        int EnemyId
        string Name
        string Description
        int MaxHP
        int CurrentHP
        int AP
        int Armor
        int Movement
        int MaxWounds
        int CurrentWounds
    }

    SWACKIE {
        int SwackieId
        string Name
        int Value
    }

    SKILL {
        int SkillId
        string Name
        int Value
    }

    ATTACK {
        int AttackId
        string Name
        int Range
        int Damage
        int MaxAmmo
        int CurrentAmmo
        string Description
        bool IsRanged
        bool IsMelee
        bool IsAOE
    }
