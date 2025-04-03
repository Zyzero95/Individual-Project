'use client'
import { AnimalInterface } from "@/app/Interfaces/animalinterface"
import Image from "next/image"
import { useRouter } from "next/navigation"
import styles from "./animalcard.module.css"

export interface AnimalData {
    data: AnimalInterface
}

export default function AnimalCard({ data }: AnimalData) {
    const router = useRouter();
  return (
    <section className={styles.anicardWrapper}>
      <figure className={styles.anicardFigure}>
        <Image 
            src={data.image}
            alt={`Image depicting ${data.name} uploaded from Unsplash.`}
            fill={true}
            sizes="1000px"
            priority={true}
        />
      </figure>
      <h2 className={styles.anicardName}>{data.name}</h2>
      <section className={styles.anicardEnvSection}>
        {data.environment.map((env) => <p key={env} className={`${styles.anicardEnv}${env}`}>{env == "CoralReef" ? "Coral Reef" : env == "DeepOcean" ? "Deep Ocean" : env == "RockyReefs" ? "Rocky Reefs": env}</p>)}
      </section>
      <button className={styles.anicardButton} type="button" onClick={() => router.push(`/${data.id}`)}>Facts</button>
    </section>
  )
}
