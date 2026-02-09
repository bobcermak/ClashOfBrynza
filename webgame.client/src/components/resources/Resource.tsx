import { type FC } from 'react';

type ReasourceProps = {
  currentAmount: number,
  maxAmount?: number,
  maxWidth?: string,
  imgSrc: string,
  color: string
}
const Resource: FC<ReasourceProps> = ({ currentAmount, maxAmount, maxWidth, imgSrc, color }) => {
  let width = 0;
  if (maxAmount && maxAmount > 0) width = (currentAmount / maxAmount) * 100;
  else {
    const softLimit = 100;
    width = 37.5 + (currentAmount / (currentAmount + softLimit)) * 60;
  }
  width = Math.min(Math.max(width, 0), 100);
  return (
    <div className="resource" style={{ width: maxWidth }}>
      <div style={{ backgroundColor: color, width: `${width}%` }}/>
      <figure>
        <img className="img-responsive" src={imgSrc} alt="Obrázek zdroje" loading='lazy' />
      </figure>
      <p className="resource__amount">{currentAmount}<span className="resource__amount__max">{maxAmount ? `/${maxAmount}` : ''}</span></p>
    </div>
  )
}
export default Resource;