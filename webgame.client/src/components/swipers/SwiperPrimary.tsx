import { type FC, type JSX, useCallback, useEffect } from "react";
import useEmblaCarousel from "embla-carousel-react";
import { GoChevronLeft, GoChevronRight } from "react-icons/go";
import "../../styles/global.css";

type SwiperPrimaryProps = {
  className?: string,
  children: JSX.Element[]
};
const SwiperPrimary: FC<SwiperPrimaryProps> = ({ className, children }) => {
  const [emblaRef, emblaApi] = useEmblaCarousel({
    loop: false,
    align: "start",
    dragFree: true,
    containScroll: "trimSnaps"
  });
  const scrollPrev = useCallback(() => emblaApi?.scrollPrev(), [emblaApi]);
  const scrollNext = useCallback(() => emblaApi?.scrollNext(), [emblaApi]);
  useEffect(() => {
    if (!emblaApi) return;;
    const interval = setInterval(() => {
      if (emblaApi.canScrollNext()) emblaApi.scrollNext();
      else emblaApi.scrollTo(0);
    }, 10000);
    return () => clearInterval(interval);
  }, [emblaApi]);
  return (
    <div className={`swiper-primary ${className}`}>
      <div className="swiper-primary__viewport" ref={emblaRef}>
        <ul className="swiper-primary__viewport-list">
          {children.map((child, index) => (
          <li key={index} className="swiper-primary__viewport-list-item">
            {child}
          </li>
        ))}
        </ul>
      </div>
      <div className="swiper-primary__buttons">
        <button onClick={scrollPrev}><GoChevronLeft className="swiper-primary__button"/></button>
        <button onClick={scrollNext}><GoChevronRight className="swiper-primary__button"/></button>
      </div>
    </div>
  )
}
export default SwiperPrimary;