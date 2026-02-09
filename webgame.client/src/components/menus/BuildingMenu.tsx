import { Close, Button } from "../../components";
import { type FC } from "react";
import { type MapBuilding } from "../../../types/mapModels";

type BuildingMenuProps = {
  isOpen: boolean;
  building?: MapBuilding;
  onClose: () => void;
  onDeleteBuilding?: (building: MapBuilding) => void;
  onBuildingUpgrade?: (building: MapBuilding) => void;
};
const BuildingMenu: FC<BuildingMenuProps> = ({ isOpen, building, onClose, onDeleteBuilding, onBuildingUpgrade }) => {
  return (
    <>
      {isOpen && (
        <div className="menu-container" onClick={onClose}>
          <div className="page__building-menu" onClick={(e) => e.stopPropagation()}>
            <div className="building-menu">
              <div className="building-menu__wrapper">
                <Close className="building-menu__close" onToggle={onClose} />
                <p className="building-menu__title">
                  {building?.building.name} - {building?.level} lvl
                </p>
                <div className="building-menu__description">
                  <div className="building-menu__description-content">
                    <p className="building-menu__description-content-text">Kapacita:</p>
                    <div className="building-menu__resource">
                      <p className="building-menu__resource-amount">{building?.building.levels.find((level) => level.level === building.level)?.capacity}</p>
                      <figure className="building-menu__resource-figure">
                        <img className="img-responsive" src="images/content/monk.png" alt="Obrázek populace" loading="lazy" />
                      </figure>
                    </div>
                  </div>
                </div>
                <div className="building-menu__upgrade-section">
                  <div>
                    <p className="building-menu__upgrade-title">Vylepšení:</p>
                    <div className="building-menu__amount">
                      <p className="building-menu__amount-text">Cena: {building?.building.levels.find((level) => level.level === building.level)?.upgradeCost}</p>
                      <figure className="building-menu__amount-figure">
                        <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce" loading="lazy" />
                      </figure>
                    </div>
                    {building?.building.levels.find((level) => level.level === building.level)?.populationCost !== 0 && (
                      <div className="building-menu__amount">
                        <p className="building-menu__amount-text">Potřebná populace: {building?.building.levels.find((level) => level.level === building.level)?.populationCost}</p>
                        <figure className="building-menu__amount-figure">
                          <img className="img-responsive" src="images/content/monk.png" alt="Obrázek populace" loading="lazy" />
                        </figure>
                      </div>
                    )}
                    {building?.building.isTownHall ? (
                      <div>
                        <p>Benefity:</p>
                        <p>Rychlost množení ovcí: +5%</p>
                        <p>Rychlost růstu populace: +5%</p>
                      </div>
                    ) : (
                      <div>
                        <p>Benefity:</p>
                        <div className="building-menu__description-content">
                          <p className="building-menu__description-content-text">Kapacita po vylepšení:</p>
                          <div className="building-menu__resource">
                            <p className="building-menu__resource-amount">{building?.building.levels.find((level) => level.level === building.level + 1)?.capacity}</p>
                            <figure className="building-menu__resource-figure">
                              <img className="img-responsive" src="images/content/monk.png" alt="Obrázek populace" loading="lazy" />
                            </figure>
                          </div>
                        </div>
                      </div>
                    )}
                  </div>
                  <div className="building-menu__upgrade-section-buttons">
                    <Button bgColor="button--primary--blue" onClick={() => { building && onBuildingUpgrade?.(building) }}>
                      Vylepšit
                    </Button>
                    {!building?.building.isTownHall && (
                      <Button bgColor="button--primary--red" onClick={() => building && onDeleteBuilding?.(building)}>
                        Odstranit
                      </Button>
                    )}
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      )}
    </>
  );
};
export default BuildingMenu;