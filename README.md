# 🏰 ClashOfBrynza | Buduj. Krm. Vládni.

> **Webová hra | Budovatelské RPG | WEB + MPA**
> Vybuduj vesnici, spravuj stáda ovcí a balancuj na hraně hladomoru.

---

<p align="center">
  <img src="/webgame.client/public/images/content/game-menu.png" width="30%" alt="Ukázka ze hry 1">
  <img src="/webgame.client/public/images/content/game-game.png" width="30%" alt="Ukázka ze hry 2">
  <img src="/webgame.client/public/images/content/game-levelup.png" width="30%" alt="Ukázka ze hry 3">
</p>

---

## 🎮 O Hře

Naše hra je jednoduché **budovatelské RPG** v prohlížeči. Hráč si buduje vlastní vesnici, rozvíjí ji, sbírá suroviny (ovce 🐑) a postupně odemyká nové možnosti.

[🚀 **Otevřít hru**](https://id-117.pslib.cloud/)

---

## ⚙️ Technologie

Používáme moderní stack, který kombinuje backend, frontend i práci s animacemi.

| Technologie | Popis |
| :--- | :--- |
| ![ASP.NET](https://img.shields.io/badge/ASP.NET-512BD4?style=flat&logo=dotnet&logoColor=white) | **Backendová logika**, API, autentizace |
| ![React](https://img.shields.io/badge/React-20232A?style=flat&logo=react&logoColor=61DAFB) | **Frontend**, dynamické UI |
| ![Konva.js](https://img.shields.io/badge/Konva.js-0D274D?style=flat&logo=javascript&logoColor=white) | **Animace** jednotek, efektů a objektů |
| ![Canvas](https://img.shields.io/badge/Canvas-E34F26?style=flat&logo=html5&logoColor=white) | **Vykreslování** mapy a herních prvků |
| ![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=white) | **Snadné nasazení** aplikace |

---

## 🎯 Gameplay

Základní ekonomický model a herní logika budovatelské strategie založené na balancování zdrojů, populace a prostoru.

### 🕹️ Přehled herního systému

Hra je založena na uzavřeném cyklu tří hlavních proměnných: **Ovce**, **Populace** a **Volná půda**. Hráč musí expandovat, aby odemkl nové technologie, ale každá expanze ohrožuje jeho potravinovou bezpečnost.

---

### 📊 Hlavní proměnné

| Proměnná       | Symbol | Popis                                                     |
| :------------- | :----- | :-------------------------------------------------------- |
| **Ovce**       | $S$    | Hlavní měna pro stavbu a zároveň potrava pro lidi.        |
| **Populace**   | $P$    | Počet obyvatel. Určuje spotřebu a odemyká upgrady.        |
| **Volná půda** | $L$    | Celková plocha mínus zastavěná plocha. Určuje limit ovcí. |

---

### ⚙️ Core Mechaniky

#### 1. Management prostoru

Každá postavená budova (dům) snižuje množství volné půdy ($L$). Množství volné půdy přímo definuje **maximální počet ovcí**, které může hráč vlastnit.

> _Důsledek:_ Čím více domů postavíš, tím méně ovcí můžeš dlouhodobě chovat.

#### 2. Spotřeba a Hladomor

Populace ke svému přežití vyžaduje neustálý přísun ovcí.

> **Stav hladomoru:** Pokud zásoba ovcí ($S$) klesne na 0, populace začne vymírat ($P$ se snižuje v čase).

#### 3. Progres (Radnice)

Radnice slouží jako technologický uzel. Její vylepšení je podmíněno dosažením určité úrovně populace.

> _Strategický prvek:_ Hráč musí často postavit více domů, než kolik dokáže jeho půda dlouhodobě uživit, jen aby "protnul" hranici pro upgrade radnice.

#### 4. Efektivita ovcí

S vyšší úrovní hráče roste efektivita produkce ovcí na jednotku volné půdy. Čím vyšší level, tím více ovcí dokáže stejná plocha uživit.

> _Důsledek:_ Progrese se vyplácí – upgrade radnice zlepšuje ekonomickou výkonnost celé vesnice.

---

### 🔄 Herní smyčka (Game Loop)

1.  **Sběr zdrojů:** Ovce se generují na volné půdě (do výše $S_{max}$).
2.  **Expanze:** Hráč utratí ovce za stavbu domů -> zvýší se populace, ale klesne $S_{max}$.
3.  **Krize:** Vyšší populace spotřebovává více ovcí. Hráč musí balancovat na hraně kapacity.
4.  **Upgrade:** Dosažení populačního cíle -> Upgrade radnice -> Nové možnosti (efektivita, vertikální růst).

---

### 🛠️ Budoucí rozšíření

- [ ] **Efektivita pastvy:** Technologie zvyšující počet ovcí na jednotku půdy.
- [ ] **Vertikální růst:** Upgrady domů (více lidí na stejné ploše)

---

<p align="center">
  <i>Vytvořeno s ❤️ týmem Bob Čermák & Víťa Dobrovský</i>
</p>