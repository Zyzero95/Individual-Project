import { AnimalInterface } from "@/app/Interfaces/animalinterface"
import styles from "./animalidcard.module.css"
import Image from "next/image"


export interface AnimalData {
    data: AnimalInterface
}

// Using Animal data fetched from ID page to render JSX elements.
export default function AnimalIdCard({ data }: AnimalData) {
  return (
    <section className={styles.idWrapper}>
        <figure className={styles.idFig}>
          <Image 
            src={data?.image}
            alt={`Image depicting ${data?.name}. Image from Unsplash`}
            fill={true}
            sizes="1000px"
            priority={true}
          />
        </figure> 
        <section className={styles.idInfoWrapper}>
          <section className={styles.idInfoGridWrapper}>
            <h2 className={styles.idName}>{data?.name}</h2>
            <section className={styles.idEnvWrapper}>
              {data?.environment.map((env) => <p key={env} className={`${styles.idEnv}${env}`}>{env == "CoralReef" ? "Coral Reef" : env == "DeepOcean" ? "Deep Ocean" : env == "RockyReefs" ? "Rocky Reefs": env}</p>)}
            </section>
            <section className={styles.idFoodSpeciesWrapper}>
              <p className={data.species === "Mammal" ? styles.idMammal : data.species === "Bird" ? styles.idBird : data.species === "Reptile" ? styles.idReptile: styles.idFish}>{data?.species}</p>
              <p className={data.foodPreference === "Carnivore" ? styles.idCarnivore : data.foodPreference === "Herbivore" ? styles.idHerbivore : data.foodPreference === "Piscivore" ? styles.idPiscivore : styles.idOmnivore}>{data?.foodPreference}</p>
            </section>
            </section>
          </section>
          <section className={styles.idDescWrapper}>
              <h3 className={styles.idDescHeading}>Description: </h3>
              <p className={styles.idDesc}>{data?.description}</p>
          </section>
        </section>
  )
}
