import styles from "./hero.module.css"
import Slideshow from "./slideshow"

// Hero Section Component with built in CSS animation.
export default function HeroSection() {
  return (
    <section className={styles.heroSection}>
      <h1 className={styles.heroHeading}>Animal Facts</h1>
      <Slideshow/>
    </section>
  )
}
