import { type FC } from "react";

type CloseProps = {
  onToggle: (value: boolean) => void;
  className?: string;
};
const Close: FC<CloseProps> = ({ onToggle, className }) => {
  return (
    <div onClick={() => onToggle(false)} className={`${className} close`} aria-label="Otevřít menu">
        <span></span>
        <span></span>
    </div>
  );
};
export default Close;