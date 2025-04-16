'use client'
import imgForest from "./Hero-Images/heroImage-Forest.jpg"
import imgSavanna from "./Hero-Images/heroImage-Savanna.jpg"
import imgRainforest from "./Hero-Images/heroImage-Rainforest.jpg"
import imgSwamp from "./Hero-Images/heroImage-Swamp.jpg"
import imgJungle from "./Hero-Images/heroImage-Jungle.jpg"
import Image from "next/image"
import { useEffect, useState, useRef } from "react"
import styles from "./hero.module.css"

const images = [
    imgForest,
    imgSavanna,
    imgRainforest,
    imgSwamp,
    imgJungle
]

// Component for making a Slideshow, using State and useRef to create a timed interval for the Slideshow. Using isPaused to pause the Slideshow when hovering over image. 
const Slideshow = () => {

    const [current, setCurrent] = useState(0);
    const [isPaused, setIsPaused] = useState(false);
    const intervalRef = useRef<NodeJS.Timeout | null>(null);

    useEffect(() => {
        if(!isPaused){
            intervalRef.current = setInterval(() => {
                setCurrent((prev) => (prev + 1) % images.length);
            }, 5000);
        }
        
        return () => {
            if(intervalRef.current) clearInterval(intervalRef.current)
        };
    }, [isPaused]);

    const handleMouseEnter = () => setIsPaused(true);
    const handleMouseLeave = () => setIsPaused(false);

  return (
    <figure className={styles.heroFig} onMouseEnter={handleMouseEnter} onMouseLeave={handleMouseLeave}>
      {images.map((src, index) => (
        <section className={`${styles.slideShowWrapper} ${index === current ? styles.active : ''}`} key={index}>
            <Image className={styles.img} src={src} alt={`Slideshow image ${index + 1}`} fill priority={index === 0} />
        </section>
        
      ))}
    </figure>
  )
}

export default Slideshow;