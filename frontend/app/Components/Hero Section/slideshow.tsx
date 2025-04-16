'use client'
import imgOne from "./Hero-Images/heroImage-1.jpg"
import imgTwo from "./Hero-Images/heroImage-2.jpg"
import imgThree from "./Hero-Images/heroImage-3.jpg"
import imgFour from "./Hero-Images/heroImage-4.jpg"
import imgFive from "./Hero-Images/heroImage-5.jpg"
import Image from "next/image"
import { useEffect, useState, useRef } from "react"
import styles from "./hero.module.css"

const images = [
    imgOne,
    imgTwo,
    imgThree,
    imgFour,
    imgFive
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