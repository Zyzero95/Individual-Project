import styles from "./hero.module.css"

// Hero Section Component with built in CSS animation.
export default function HeroSection() {
  return (
    <section className={styles.heroSection}>
      <figure className={styles.heroFig}></figure>
    </section>
  )
}
