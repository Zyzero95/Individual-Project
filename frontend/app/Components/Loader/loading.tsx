import Image from "next/image";
import turtleSpinner from "../../../public/turtle-spinner.svg";
import styles from "./loading.module.css";


export default function Loading() {
  return (
    <main className={styles.loader}>
      <section className="loaderWrapper">
        <Image 
            src={turtleSpinner}
            alt="A loading spinner with a turtle. SVG taken from https://www.svgrepo.com/svg/11827/turtle"
            width={100}
            height={100}
        />
      </section>
    </main>
  )
}
