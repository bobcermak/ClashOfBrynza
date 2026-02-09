import { Item, Close, SwiperPrimary } from "../../components";
import { type FC } from "react";
import { type Building } from "../../../types/mapModels";

type ShopProps = {
  isOpen: boolean;
  buildings: Building[];
  onClose: () => void;
  onBuildingBuy?: (building: Building) => void;
};
const Shop: FC<ShopProps> = ({ isOpen, buildings, onClose, onBuildingBuy }) => {
  return (
    <>
      {isOpen && (
        <div className="menu-container" onClick={onClose}>
          <div className="page__shop" onClick={(e) => e.stopPropagation()}>
            <div className="shop">
              <Close className="shop__close" onToggle={onClose} />
              <p className="shop__title">Obchod</p>
              <SwiperPrimary>
                {buildings
                  .filter((building: Building) => building.buildingId !== 1)
                  .map((building: Building) => (
                    <Item imgSrc={building.imageUrl} price={building.initialCost} onBuy={() => onBuildingBuy?.(building)} />
                  ))}
              </SwiperPrimary>
            </div>
          </div>
        </div>
      )}
    </>
  );
};
export default Shop;