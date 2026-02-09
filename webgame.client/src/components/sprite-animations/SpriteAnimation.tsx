import { type FC, useEffect, useRef, useState, useMemo, memo } from 'react';
import { Sprite } from 'react-konva';
import useImage from 'use-image';
import Konva from 'konva';

export type AnimationMap = {
    [key: string]: number[];
};
export type SpriteAnimationProps = {
    id?: string;
    src: string;
    animations?: AnimationMap;
    animation?: string;
    frameWidth?: number;
    frameHeight?: number;
    columns?: number;
    rows?: number;
    frameRate?: number;
    loop?: boolean;
    autoplay?: boolean;
    x?: number;
    y?: number;
    scaleX?: number;
    scaleY?: number;
    rotation?: number;
    opacity?: number;
    listening?: boolean;
    delay?: number;
    onClick?: () => void;
    onMouseEnter?: () => void;
    onMouseLeave?: () => void;
    zIndex?: number;
};
const SpriteAnimation: FC<SpriteAnimationProps> = memo(({
    src,
    animations,
    animation,
    frameWidth,
    frameHeight,
    columns,
    rows,
    frameRate = 10,
    loop = true,
    autoplay = true,
    x = 0,
    y = 0,
    scaleX = 1,
    scaleY = 1,
    rotation = 0,
    opacity = 1,
    listening = true,
    delay = 0,
    onClick,
    onMouseEnter,
    onMouseLeave,
    zIndex,
    ...rest
}) => {
    const [image] = useImage(src);
    const spriteRef = useRef<Konva.Sprite>(null);
    const [isRunning, setIsRunning] = useState<boolean>(false);
    const finalAnimations = useMemo(() => {
        if (animations) return animations;
        if (frameWidth && frameHeight && columns && rows) {
            let validColumns = columns;
            let validRows = rows;
            let effectiveFrameWidth = frameWidth;
            let effectiveFrameHeight = frameHeight;
            if (image) {
                if (image.width < frameWidth) effectiveFrameWidth = image.width;
                if (image.height < frameHeight) effectiveFrameHeight = image.height;
                const imgCols = Math.floor(image.width / effectiveFrameWidth);
                const imgRows = Math.floor(image.height / effectiveFrameHeight);
                if (imgCols < columns) validColumns = imgCols;
                if (imgRows < rows) validRows = imgRows;
                if (validColumns === 0) validColumns = 1;
                if (validRows === 0) validRows = 1;
            }
            const frames = [];
            for (let r = 0; r < validRows; r++) {
                for (let c = 0; c < validColumns; c++) {
                    frames.push(c * effectiveFrameWidth, r * effectiveFrameHeight, effectiveFrameWidth, effectiveFrameHeight);
                }
            }
            return { 'default': frames };
        }
        return {};
    }, [animations, frameWidth, frameHeight, columns, rows, image]);
    const [imageLoaded, setImageLoaded] = useState(false);
    useEffect(() => {
        if (image) {
            const expectedWidth = (columns || 1) * (frameWidth || 0);
            const expectedHeight = (rows || 1) * (frameHeight || 0);
            if (frameWidth && columns && image.width < expectedWidth) {
                console.warn(`[SpriteAnimation] Image ${src} is too small (${image.width}px) for defined frames (${expectedWidth}px). Clamping to fit.`);
            }
            if (frameHeight && rows && image.height < expectedHeight) {
                console.warn(`[SpriteAnimation] Image ${src} is too small (${image.height}px) for defined frames (${expectedHeight}px). Clamping to fit.`);
            }
            setImageLoaded(true);
        }
    }, [image, frameWidth, frameHeight, columns, rows, src]);
    const currentAnimation = animation || 'default';
    useEffect(() => {
        if (image && spriteRef.current && autoplay && imageLoaded) {
            if (!isRunning) {
                if (delay > 0) {
                    const timer = setTimeout(() => {
                        if (spriteRef.current) {
                            spriteRef.current.start();
                            setIsRunning(true);
                        }
                    }, delay);
                    return () => clearTimeout(timer);
                } else {
                    spriteRef.current.start();
                    setIsRunning(true);
                }
            }
        }
    }, [image, isRunning, autoplay, delay, imageLoaded]);
    useEffect(() => {
        if (spriteRef.current && currentAnimation) spriteRef.current.animation(currentAnimation);
        if (spriteRef.current && zIndex !== undefined) {
            spriteRef.current.zIndex(zIndex);
        }
    }, [currentAnimation, zIndex]);
    if (!image || !imageLoaded) return null;
    return (
        <Sprite
            id={rest.id}
            ref={spriteRef}
            x={x}
            y={y}
            scaleX={scaleX}
            scaleY={scaleY}
            rotation={rotation}
            opacity={opacity}
            image={image}
            animation={currentAnimation}
            animations={finalAnimations}
            frameRate={frameRate}
            frameIndex={0}
            loop={loop}
            listening={listening}
            onClick={onClick}
            onMouseEnter={onMouseEnter}
            onMouseLeave={onMouseLeave}
        />
    );
});
export default SpriteAnimation;