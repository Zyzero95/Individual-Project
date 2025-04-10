import Image from "next/image";
import turtleSpinner from "../../../public/turtle-spinner.svg";
import styles from "./loading.module.css";

// Loading spinner Component for when data hasn't been fetched completely.
export default function Loading() {
  return (
    <main className={styles.main}>
      <section className={styles.loaderWrapper}>
        <figure className={styles.loadingFig}>
          <Image 
              className={styles.loadingImg}
              src={turtleSpinner}
              alt="A loading spinner with a turtle. SVG taken from https://www.svgrepo.com/svg/11827/turtle"
              width={100}
              height={100}
          />
        </figure>
      </section>
    </main>
  )
}
