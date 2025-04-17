'use client'
import { AnimalInterface } from "@/app/Interfaces/animalinterface"
import Image from "next/image"
import { useRouter } from "next/navigation"
import styles from "./animalcard.module.css"

export interface AnimalData {
    data: AnimalInterface
}

export default function AnimalCard({ data }: AnimalData) {
// Navigation hook to ID page.
    const router = useRouter();
// Renders fetched data via HTML elements.
  return (
    <section className={styles.anicardWrapper}>
      <figure className={styles.anicardFigure}>
        <Image 
            src={data.image}
            alt={`Image depicting ${data.name}. Uploaded from Unsplash.`}
            fill={true}
            sizes="450px"
            priority={true}
        />
      </figure>
      <section className={styles.anicardNameSection}>
        <h2 className={styles.anicardName}>{data.name}</h2>
        <p className={styles.anicardNameLatin}>{data.latinName}(latin)</p>
      </section>
      <section className={styles.anicardEnvSection}>
        {data.environment.map((env) => <p key={env} className={`${styles.anicardEnv}${env}`}>{env == "CoralReef" ? "Coral Reef" : env == "DeepOcean" ? "Deep Ocean" : env == "RockyReefs" ? "Rocky Reefs": env}</p>)}
      </section>
      <button className={styles.anicardButton} type="button" onClick={() => router.push(`/${data.id}`)}>Facts about me!</button>
    </section>
  )
}
