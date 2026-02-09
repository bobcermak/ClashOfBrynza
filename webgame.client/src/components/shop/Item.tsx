import { Button } from "../../components"
import { type FC } from 'react';

type ItemProps = {
    imgSrc: string,
    price: number,
    onBuy: () => void
}
const Item: FC<ItemProps> = ({ imgSrc, price, onBuy }) => {
  return (
    <div className="item">
        <figure className="item__figure">
            <img className="img-responsive" src={imgSrc === "/images/buildings/2.png" ? "/images/buildings/2-1.png" : imgSrc} alt="Obrázek budovy" loading='lazy'/>
        </figure>
        <div className="item__details">
           <div className="item__info">
                <p className="item__info-content">{price}</p>
                <figure className="item__info-sheep">
                    <img className="img-responsive" src="images/content/sheep.png" alt="Obrázek ovce" loading='lazy'/>
                </figure>
            </div>
            <div className="item__action">
                <Button bgColor="button--primary--red" onClick={onBuy}>Koupit</Button>
            </div> 
        </div>
    </div>
  )
}
export default Item;